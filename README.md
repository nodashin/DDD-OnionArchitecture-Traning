## リポジトリの概要

オニオンアーキテクチャでDDDの実装を勉強するための勉強用リポジトリ。  
システムは、Backlogやredmineのような課題管理システム。  
ただし機能の充実化は目的からそれるため、あくまで最低限の機能のみとしている。  

## ソリューションフォルダ構成

|フォルダ|役割|
|-|-|
|PresentationLayer|Presentation層に位置するプロジェクトを格納する。|
|InfrastructureLayer|Infrastructure層に位置するプロジェクトを格納する。|
|ApplicationLayer|Application Service層に位置するプロジェクトを格納する。|
|DomainLayer|DomainService層及びDomainModel層に位置するプロジェクトを格納する。|

## ソリューション構成

|フォルダ|プロジェクト|役割|
|-|-|-|
|PresentationLayer|IssueManagementSystem.Web|ASP.NET MVCアプリケーション|
|InfrastructureLayer|IssueManagementSystem.Persistence|永続化に関するプロジェクト。<br>DBやログインしたユーザーの情報等。|
|InfrastructureLayer|IssueManagementSystem.Platform|システムの基幹となるテクノロジー群。<br>横断的関心事の集まり|
|ApplicationLayer|IssueManagementSystem.ApplicationService.Web|ASP.NET MVCアプリケーションに対応するApplicationService。|
|DomainLayer|IssueManagementSystem.DomainService|ビジネスロジック。|
|DomainLayer|IssueManagementSystem.DomainModel|ドメインモデル。|

## 境界づけられたコンテキスト

|コンテキスト名|役割|
|-|-|
|Auth|認証系|
|Issue|課題管理系|

## 参考資料
[.NETのエンタープライズアプリケーションアーキテクチャ](https://shop.nikkeibp.co.jp/front/commodity/0000/P98480/)  
[ドメイン駆動 + オニオンアーキテクチャ概略](https://qiita.com/little_hand_s/items/2040fba15d90b93fc124)  
