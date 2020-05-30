---
theme : "black"
transition : "default"
---

<style type="text/css">
  .reveal h1,
  .reveal h2,
  .reveal h3,
  .reveal h4,
  .reveal h5,
  .reveal h6 {
    text-transform: none;
  }
  p { text-align: left; }
</style>

# XR Interaction Toolkit
## を使ってみた話

<div style="float:right;">

@yusuke-ota
</div>

---

<!--
使ってみる
* VR(サンプルデモで大体わかるから割愛)
* AR <= サンプルがほとんど無いので、触ってみて、まとめる

-->

## 自己紹介

@yusuke-ota

アマチュアプログラマー  
C++(PlatformIO)、C#(Unity)、Rust、Ruby

最近気になること  
Unreal Engine、シェーダー、サーバー

---

## XR開発環境(Unity公式)

<div style="width: 60%; float: left">

<img src="https://blogs.unity3d.com/wp-content/uploads/2020/01/image1-2.png" alt="Unity XR Tech Stack">
</div>

<div style="width: 40%; float: right">

[画像引用]  
Unity XR  
プラットフォームの  
最新情報
<https://blogs.unity3d.com/jp/2020/01/24/unity-xr-platform-updates/>

</div>

---

### MARS

は分からないので、飛ばします  
(preview版が出たら触りたい)

---

### AR Foundationとは

別機種間のAR関係の処理を**同じコード**で書ける

**Ver3.x**  
AR Core、AR Kit対応

**Ver4.x(preview)**  
AR Core、AR Kit、**HoloLens、Magic Leap One**対応

---

### AR Foundation蛇足

AR FoundationでARアプリを作って  
実機上で起動できない(起動してすぐに落ちる)場合

ARCore XR PluginやARKit XR Pluginが  
**入っていない可能性が高い**

// TODO: 動画再生

---

### XR Interaction Toolkitとは

入力周りのあれこれの実装を楽にしてくれる  
**処理の共通化もできる**

**VR**: つかむ動作等  
**AR**: ARレイキャスト等

---

## XR Interaction Toolkit

### AR、VRでの機能対応表

// TODO: 調べる

|機能|AR|VR|
|:---:|:---:|:---:|
|オブジェクトインタラクション|〇|〇|
|UIインタラクション|〇|〇|
|オブジェクト配置|〇|×|
|ロコモーション(テレポーテション)|×|〇|

---

### デモ動画

// TODO: 動画再生

---

### 機能〇〇

<div style="float:left;">

Unity上の画像

</div>

<div style="float:right;">

AR上の画像
</div>

---

## まとめ

<span style="font-size: 35px" >

UnityはXR系の開発環境を一本化しようとしているぞ  
AR,MR周りはAR Foundationを使うといいぞ  
XR Interaction Toolkitで人間からの入力を共通化できるぞ  
なんかXR Interaction Toolkitの機能の説明をしたぞ  

</span>

<span style="font-size: 50px" >

そんなことより  
**〇〇 XR Pluginの入れ忘れに気を付けよう**

</span>

---

## 参考文献

Unity XR プラットフォームの最新情報  
<https://blogs.unity3d.com/jp/2020/01/24/unity-xr-platform-updates/>

About AR Foundation  
<https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.0/manual/index.html>

---

## 参考文献(XR Interaction Toolkit)

XR Interaction ツールキットのプレビューパッケージ公開  
<https://blogs.unity3d.com/jp/2019/12/17/xr-interaction-toolkit-preview-package-is-here/>

XR Interaction Toolkit  
<https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@0.9/manual/index.html>

XR Interaction Examples  
<https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples>
