# .NET MAUI 基本講座
LinkedInラーニングの「.NET MAUI 基本講座」コース用のリポジトリです。このコースは [LinkedInラーニング][lil-course-url]で視聴できます。

![.NET MAUI 基本講座][lil-thumbnail-url] 
.NET MAUIはWindowsやiOS、Androidなどのマルチプラットフォームに対応したアプリケーションを作成できるフレームワークです。C#とXAMLを使い、ひとつのコードベースでネイティブ プラットフォームのようなアプリを構築します。このコースでは.NET MAUIの基本的な使い方について学びます。WindowsやMacを利用した開発環境の準備方法から、画面を定義するためのコントロールの使い方、デバイス情報やセンサー情報を取得する方法をわかりやすく解説します。このコースを学習することで.NET MAUIを使ってすぐに開発を始めることができるようになるでしょう。

## リポジトリの使い方
このリポジトリには必要に応じてブランチが設けられています。ブランチのポップアップメニューを使用して、使用するブランチに切り替えたあとにコースを視聴してください。またURLに`「/tree/ブランチ名」`を追加することで、アクセスしたいブランチに移動することも可能です。

## ブランチ
ブランチはレッスンごとに作成されている場合があります。その場合はブランチ名に`「章番号_レッスン番号」`が付けられています。例えば`「02_03」`という名前のブランチは、2章の上から3番目のレッスン用のブランチとなります。

レッスン前と後のコードを格納しているブランチもあります。該当ブランチには「開始時」（beginning）を表す`「b」`と、「終了時」（ending）を表す`「e」` がブランチ名についています。`「b」`のブランチにはレッスン開始時点のコードが、`「e」`のブランチにはレッスン終了時点のコードが格納されています。また「main」のブランチにはコードの最終形が格納されています。

ファイルに変更を加えた後に、エクササイズファイルのブランチを次のブランチに切り替えたさい、次のようなメッセージが表示されることがあります。

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

この問題を解決するには：
	
    次のコマンドで変更を加えます：git add .
	次のコマンドで変更をコミットします：git commit -m "some message"

## インストール
1. エクササイズファイルを使用するには`Visual Studio 2022以降`のインストール時またはVisual Studio Installerから設定できるワークロードから「.NETマルチプラットフォームアプリのUI開発」を選択する必要があります。
	- [Visual Studio](https://visualstudio.microsoft.com/ja/downloads/)
2. リポジトリをWindows PCにクローンしてください。
3. フォルダーの中にある`ソリューションファイル（拡張子が.sln）`をVisual Studioで開くことで実行することができます。

### インストラクター

**西村 誠**

_プログラマー、Microsoft MVP_

この講師の他のコースを視聴する：[LinkedInラーニング](https://www.linkedin.com/learning/instructors/13315091)

[lil-course-url]: https://www.linkedin.com/learning/visual-studio-2022-essential-training
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D560DAQHqiDI4viUJxQ/learning-public-crop_675_1200/0/1690215687891?e=2147483647&v=beta&t=E_cm5fe4EvRJYIEFXAOD17n0fAugg2jmpFVNsos-fl4
