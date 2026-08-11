# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## 项目概述

BBDC（背单词）是一款 .NET Framework 4.5 WinForms 英语词汇学习桌面应用，使用 Visual Studio 2015 开发。

## 构建与运行

```bash
# 使用 MSBuild 构建（需安装 .NET Framework 4.5 SDK）
msbuild Demo\BBDC.sln /p:Configuration=Debug

# 或直接打开解决方案文件
start Demo\BBDC.sln
```

无自动化测试项目，无 lint/格式化配置。

## 架构：三层架构

```
BBDC.UI (WinForms, 启动项目)
  → BBDC.BLL (业务逻辑层)
    → BBDC.DAL (数据访问层)
      → SQL Server (BBDCDB)
  → BBDC.Model (实体模型, 所有层共享)
```

**项目依赖关系**：UI 引用 BLL 和 Model；BLL 引用 DAL 和 Model；DAL 引用 Model。UI 层不直接引用 DAL。

## 数据层 (BBDC.DAL)

**SqlHelper** (`Demo/BBDC.DAL/SqlHelper.cs`) 是数据库访问基类（`abstract class`），提供四个静态方法：
- `ExecuteNonQuery` — INSERT/UPDATE/DELETE
- `ExecuteReader` — 返回 `SqlDataReader`
- `ExecuteDataset` — 返回 `DataSet`（最常用）
- `ExecuteScalar` — 返回单值

每个 DAL 类（`DCDAL`, `UserDAL`, `DictDAL`, `UidDAL`, `DetailDAL`, `FanyiDAL`, `TestDAL`）通过 `SqlHelper` 执行原始 SQL。**注意**：部分 DAL 方法存在 SQL 注入风险——动态拼接表名与值未做参数化处理。

数据库连接字符串定义在 `Demo/BBDC.UI/App.config` 中：
```
Data Source=.;Initial Catalog=BBDCDB;Integrated Security=SSPI
```
使用本地 SQL Server 实例，Windows 集成认证。

## 数据库设计关键约定

- **每本单词书 = 一张独立数据库表**：`dict` 表存书元数据（`bookid` 列存实际表名，`describe` 列存显示名）。`DCDAL` 的所有操作都接收 `book` 参数拼接为表名。
- **每个用户 = 一张独立进度表**：表名格式为 `U` + userid（如 `U542`），存储该用户背过的单词记录（`bookid`, `wordid`, `review`, `game`, `error`）。建表逻辑在 `UserDAL.Add()` 中。
- **`[User]` 表**（方括号是因为 User 是 SQL 关键字）存储用户信息，包含头像（`image` 列，`byte[]` 类型）。

## 业务层 (BBDC.BLL)

BLL 层基本为 DAL 的薄封装，主要职责是数据传递。特殊逻辑：
- `UserBLL.Login()` — 明文密码校验
- `UserBLL.Add()` — 注册前检查用户名是否已存在
- `FanyiBLL.GetWord()` — 根据 `type` 参数分发英译汉/汉译英
- `DCBLL` — 提供 `DataTableToList` 将 `DataTable` 转换为 `List<DCInfo>`，被多处复用

## UI 层 (BBDC.UI) 窗体说明

| 窗体 | 功能 |
|------|------|
| `FrmLogin` | 登录入口，使用 IrisSkin4 换肤（`vista1.ssk`），以模式对话框打开 |
| `FrmRegister` | 注册，通过委托 `EventLoadingInfo` 回传注册信息到登录窗 |
| `FrmForgotPwd` | 忘记密码 |
| `FrmBBDC` | 主界面：左侧 TreeView 导航，右侧 Panel 切换（背单词/词库/翻译/测试/游戏/设置） |
| `FrmDict` / `FrmDictPlus` | 词库管理（单例模式） |
| `FrmDelete` | 删除单词确认窗（单例模式） |
| `FrmTest` | 测试模式：看中文拼英文，限时计分 |
| `FrmGame` | 贪吃蛇单词游戏（两种模式）：Mode 0 逐词拼字母，Mode 1 连续拼多词 |
| `FrmPlan` | 学习计划/记忆策略设置 |
| `FrmUserInfo` | 用户个人信息编辑 |

**跨窗体通信**：`UserLoginInfo` 静态类保存当前登录用户 ID，委托 `EventLoadingInfo` 用于窗体间事件回调。`FrmDict` 和 `FrmDelete` 使用单例模式（`GetSington` 方法）。

**程序入口** (`Program.cs`)：先以模式对话框打开 `FrmLogin`，登录成功后进入 `FrmBBDC` 主窗体。

## 外部依赖

- **SpeechLib** (COM Interop)：Windows SAPI 语音朗读，用于单词发音
- **IrisSkin4**：第三方 WinForms 换肤控件（`IrisSkin4.dll`）

## 注意事项

- 大量 DAL 方法使用字符串拼接构造 SQL（而非参数化），修改数据库相关代码时应注意 SQL 注入风险。
- 项目无单元测试，修改逻辑后需手动运行 WinForms 应用验证。
- `Demo/BBDC.UI/bin/Debug/` 下有一些 `.ts` 文件（如 `Wordsc1.ts`），不是 TypeScript——是运行时生成的单词缓存文本文件。
- .NET Framework 4.5，非 .NET Core/.NET 5+，不可跨平台运行。
