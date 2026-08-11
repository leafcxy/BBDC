# BBDC — 背单词

BBDC 是一款基于 .NET Framework 4.5 的 Windows 桌面英语词汇学习应用，采用 WinForms 技术构建，通过闪卡记忆、测试闯关、贪吃蛇游戏等多种方式帮助用户高效背单词。

## 功能特性

- **用户系统**：注册、登录、忘记密码、个人头像与昵称设置
- **词库管理**：支持多本单词书，可自定义增删改单词
- **单词记忆**：闪卡式背单词，按计划逐词学习，记录学习进度
- **中英互译**：内置词典，支持英译汉和汉译英查询
- **单词测试**：看中文拼英文，限时计分，自动记录正确率
- **单词游戏**：贪吃蛇玩法，通过收集字母拼出单词（两种模式）
- **语音朗读**：调用 Windows SAPI 引擎朗读单词和例句
- **记忆策略**：自定义每次背诵单词数量

## 技术栈

| 层级 | 技术 |
|------|------|
| 框架 | .NET Framework 4.5 |
| 界面 | Windows Forms (WinForms) |
| 数据库 | SQL Server（本地实例，集成认证） |
| 数据访问 | ADO.NET（DataSet / SqlDataReader） |
| 语音 | SpeechLib COM (SAPI) |
| 换肤 | IrisSkin4 |

## 项目结构

```
Demo/
├── BBDC.sln                  # 解决方案文件
├── BBDC.Model/               # 实体模型层
│   ├── UserInfo.cs           # 用户信息实体
│   ├── DCInfo.cs             # 单词实体 (wordid, word, mean)
│   ├── DictInfo.cs           # 词库元数据 (describe, bookid)
│   ├── DetailInfo.cs         # 单词详细信息（多义项+例句）
│   └── UidInfo.cs            # 用户学习进度实体
├── BBDC.DAL/                 # 数据访问层
│   ├── SqlHelper.cs          # 数据库操作基类（ExecuteNonQuery/Reader/Dataset/Scalar）
│   ├── UserDAL.cs            # 用户数据访问
│   ├── DCDAL.cs              # 单词数据访问
│   ├── DictDAL.cs            # 词库元数据访问
│   ├── DetailDAL.cs          # 单词详情访问
│   ├── UidDAL.cs             # 用户进度访问
│   ├── FanyiDAL.cs           # 翻译查询访问
│   └── TestDAL.cs            # 测试相关访问
├── BBDC.BLL/                 # 业务逻辑层
│   ├── UserBLL.cs            # 用户业务（注册校验、登录验证）
│   ├── DCBLL.cs              # 单词管理业务
│   ├── DictBLL.cs            # 词库管理业务
│   ├── DetailBLL.cs          # 单词详情业务
│   ├── UidBLL.cs             # 学习进度业务
│   ├── FanyiBLL.cs           # 翻译业务
│   └── TestBLL.cs            # 测试业务
└── BBDC.UI/                  # 界面层（启动项目）
    ├── Program.cs            # 程序入口
    ├── App.config            # 数据库连接配置
    ├── FrmLogin.cs           # 登录窗体
    ├── FrmRegister.cs        # 注册窗体
    ├── FrmForgotPwd.cs       # 忘记密码
    ├── FrmBBDC.cs            # 主界面（导航+功能面板）
    ├── FrmDict.cs            # 词库管理（单例）
    ├── FrmDictPlus.cs        # 新增词库（单例）
    ├── FrmDelete.cs          # 删除单词（单例）
    ├── FrmTest.cs            # 单词测试
    ├── FrmGame.cs            # 贪吃蛇单词游戏
    ├── FrmPlan.cs            # 学习计划设置
    ├── FrmUserInfo.cs        # 个人信息编辑
    └── UserLoginInfo.cs      # 静态登录状态类
```

## 数据库设计

数据库名：`BBDCDB`，连接字符串在 `Demo/BBDC.UI/App.config` 中配置。

### 核心表

| 表名 | 说明 |
|------|------|
| `[User]` | 用户表，存储账号、密码（明文）、昵称、头像（byte[]）、当前学习进度 |
| `dict` | 词库元数据表（`describe` 书名, `bookid` 对应实际单词表名） |
| `Nw1` | 单词详情表（多义项释义和例句） |

### 动态表设计

- **单词书表**：每本单词书是一张独立数据库表（如 `c1`、`n3`、`d4` 等），表名存储在 `dict.bookid` 中。每张表结构为 `(wordid, word, mean)`。
- **用户进度表**：每个用户注册时自动创建一张个人进度表，表名格式为 `U` + userid（如 `U542`），记录该用户背过的单词和游戏/测试成绩。

## 快速开始

### 环境要求

- Windows 操作系统
- .NET Framework 4.5
- SQL Server（LocalDB 或完整实例）
- Visual Studio 2015+（推荐 VS 2015）

### 配置数据库

1. 在 SQL Server 中创建数据库 `BBDCDB`
2. 修改 `Demo/BBDC.UI/App.config` 中的连接字符串：

```xml
<connectionStrings>
  <add name="BBDCConn" connectionString="Data Source=.;Initial Catalog=BBDCDB;Integrated Security=SSPI"/>
</connectionStrings>
```

### 构建运行

```bash
# 使用 MSBuild 命令行构建
msbuild Demo\BBDC.sln /p:Configuration=Debug

# 或使用 Visual Studio 打开解决方案
start Demo\BBDC.sln
```

也可直接在 Visual Studio 中按 F5 运行。

## 注意事项

- 本项目为 .NET Framework 4.5，不可跨平台运行
- 密码以明文存储，仅适用于本地学习用途
- 部分数据访问代码使用字符串拼接 SQL，存在注入风险
- 无单元测试覆盖，修改后需手动回归测试
