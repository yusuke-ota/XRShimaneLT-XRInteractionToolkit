---
marp: true
theme: gaia
paginate: true
style: |
  section {
    padding-top: 80px;
  }
  footer {
    margin-left: 20px;
  }
  h1 {
    padding-top: 100px;
  }
  h2 {
    font-weight: 100;
  }
  h3 {
    margin-top: 10px;
    font-weight: 100;
    color: #11a3d4;
  }
  h4 {
    font-weight: 100;
  }
  ul li {
    padding-bottom: 20px;
  }
  ul ul li {
    padding-bottom: 0px;
  }
  code {
    background: #eee;
    color: #000;
  }
---

# XR Interaction Toolkitを使ってみた話

@yusuke-ota

---
<!-- 
XR開発環境(Unity公式周り)
MARS
AR Foundation
XR Interaction Toolkit
使ってみる
* VR(サンプルデモで大体わかるから割愛)
* AR <= サンプルがほとんど無いので、触ってみて、まとめる

-->

## XR開発環境(Unity公式周り)

![h:350](./DocumentImage/image1-2.png)

<!--
公開用に画像を削除しました
この画像を表示していました
<https://blogs.unity3d.com/wp-content/uploads/2020/01/image1-2.png>
-->

[画像引用] Unity XR プラットフォームの最新情報
<https://blogs.unity3d.com/jp/2020/01/24/unity-xr-platform-updates/>

---

### MARS

は分からないので、飛ばします

---

### AR Foundationとは

別機種間のAR関係の処理を同じコードで書ける

**Ver3.x**
AR Core、AR Kit対応

**Ver4.x(preview)**
AR Core、AR Kit、**HoloLens、Magic Leap One**対応

---

### AR Foundation蛇足

AR FoundationでARアプリを作って
実機上で起動できない(起動してすぐに落ちる)場合

ARCore XR PluginやARKit XR Pluginが**入っていない可能性が高い**

---

### XR Interaction Toolkitとは

XR系でよく使う入力周りのあれこれの実装を楽にしてくれる
**処理の共通化もできる**

* **VR**: つかむ動作等
* **AR**: ARレイキャスト等

---

## XR Interaction Toolkit

### AR、VRでの機能対応表

// TODO: 調べる
|機能|AR|VR|
|:--:|:--:|:--:|
||||
||||
||||
||||
||||
||||

---

### デモ動画

// TODO: 再生

---

### 機能〇〇

Unity上の画像 | AR上の画像

---

## まとめ

* UnityはXR系の開発環境を一本化使用としているぞ
* AR,MR周りはAR Foundationを使うといいぞ
* XR Interaction Toolkitを使うと人間からの入力を共通化できるぞ
* なんかXR Interaction Toolkitの機能の説明をしたぞ

そんなことより**〇〇 XR Pluginの入れ忘れに気を付けよう**

---

## 参考文献

* Unity XR プラットフォームの最新情報
<https://blogs.unity3d.com/jp/2020/01/24/unity-xr-platform-updates/>
* About AR Foundation
<https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.0/manual/index.html>

---

## 参考文献((XR Interaction Toolkit)

* XR Interaction ツールキットのプレビューパッケージ公開
<https://blogs.unity3d.com/jp/2019/12/17/xr-interaction-toolkit-preview-package-is-here/>
* XR Interaction Toolkit
<https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@0.9/manual/index.html>
* XR Interaction Examples
<https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples>