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
</style>

# XR Interaction Toolkit
## を使ってみた話

<div style="float:right;">

@yusuke-ota

</div>

---

<!--
* AR <= サンプルがほとんど無いので、触ってみて、まとめる

-->

## 自己紹介

@yusuke-ota

**アマチュアプログラマー**  
C++(PlatformIO)、C#(Unity)、Rust、Ruby

**最近気になること**  
Unreal Engine、シェーダー、サーバー

---

## XR開発環境(Unity公式)

<div style="width: 60%; float: left">

<img src="https://blogs.unity3d.com/wp-content/uploads/2020/01/image1-2.png" alt="Unity XR Tech Stack">

</div>

<div style="width: 40%; float: right; text-align: left;">

[画像引用]  
Unity XR  
プラットフォームの  
最新情報
<https://blogs.unity3d.com/jp/2020/01/24/unity-xr-platform-updates/>

</div>

---

### MARS

は分からないので、飛ばします  
(6/1から使えるらしい)

---

### AR Foundationとは

別機種間のAR関係の処理を**同じコード**で書ける  
(機種依存機能は除く)

**Ver3.x**  
AR Core、AR Kit対応

**Ver4.x(preview)**  
AR Core、AR Kit、**HoloLens、Magic Leap One**対応

---

### AR Foundation蛇足

<div style="text-align: left;">

AR FoundationでARアプリを作って  
実機上で起動できない(起動してすぐに落ちる)場合

ARCore XR PluginやARKit XR Pluginが  
**入っていない可能性が高い**

</div>

---

ARCoreXRPluginがない時の動作.gif

![ARCoreXRPluginがない時の動作.gif](./ImageForDocument/ARCoreXRPluginがない時の動作.gif)

---

### XR Interaction Toolkitとは

<div style="text-align: left;">

入力周りのあれこれの実装を楽にしてくれる  

</div>

**VR**: UI操作、つかむ動作、スナップ機能、テレポーテーション  
**AR**: UI操作、オブジェクト操作、オブジェクト生成

---

## XR Interaction Toolkit

### AR、VRでの機能対応表

|機能|AR|VR|
|:---:|:---:|:---:|
|オブジェクトインタラクション|〇|〇|
|UIインタラクション|〇|〇|
|オブジェクト配置|〇|×|
|ロコモーション|×|〇|

---

### 機能分類表

// TODO: 作成

---

## オブジェクトインタラクション

**Interactor**

動作の主体(主にコントローラ)

**Interactable**

動作の客体(主にキューブなどのオブジェクト)

---

## XR(要コントローラー)

### Interactor

動作の主体(主にコントローラ)

---

#### XRRayInteractor

レイキャストを出す機能、物の指定とか

<video height="500"><source src="ImageForDocument/RayInteractor.mp4"></video>

---

![XRRayInteractor](./ImageForDocument/XRRayInteractor.png)

---

#### XRDirectInteractor

直接オブジェクトを触って操作する機能

<video height="500"><source src="ImageForDocument/DirectInteractor.mp4"></video>

---

要コライダー

![XRDirectInteractor](./ImageForDocument/XRDirectInteractor.png)

---

#### XRSocketInteractor

対応するオブジェクトを設定した位置に戻す機能  
イメージとしては磁石  

<video height="500"><source src="ImageForDocument/SocketInteractor.mp4"></video>

---

![XRSocketInteractor](ImageForDocument/XRSocketInteractor.png)

---

### Interactable

動作の客体(主にキューブなどのオブジェクト)

---

#### XRSimpleInteractable

カーソルの操作によってイベントを発火させることができる機能

<video height="500"><source src="ImageForDocument/SimpleInteractable.mp4"></video>

---

![XRSimpleInteractable](./ImageForDocument/XRSimpleInteractable.png)

---

#### XRGrabInteractable

XRSimpleInteractable + つかむ機能  
基本的に持ち運び出来るオブジェクトにはこっち

<video height="500"><source src="ImageForDocument/GrabInteractable.mp4"></video>

---

<div style="width:70%; float:left;">

<img src=./ImageForDocument/XRGrabInstractable.png alt="XRGrabInstractable">

</div>

<div style="width:30%; float:right; font-size: 30px; text-align: left;">

Velocity: 速度を加えて移動させる(ばねっぽい挙動)  
Kinematic: 座標を書き換えて移動させる  
Instantaneous: Physicsがかからない(Dynamic updateっていつ?)

</div>

---

#### XRTintInteractableVisual

カーソルホバー、選択時などで、オブジェクトの色を変えて強調する機能  
要[Emission](https://docs.unity3d.com/ja/2019.1/Manual/StandardShaderMaterialParameterEmission.html) 対応シェーダー、Interactable

<video height="500"><source src="ImageForDocument/TintInteractableVisual.mp4"></video>

---

![XRTintInteractable.png](./ImageForDocument/XRTintInteractable.png)

---

### UIインタラクション

---

#### TrackedDeviceGraphicRaycaster

コントローラーがあればVR,AR両対応できるらしい
コントローラー付きのARデバイスを持っていないので、VRのみ確認

<video height="500"><source src="ImageForDocument/TrackedDeviceGraphicRaycaster.mp4"></video>

---

uGUIに重ねて使う  
XRRayInteractorで操作出来るようになる

![TrackedDeviceGraphicRaycaster](./ImageForDocument/TrackedDeviceGraphicRaycaster.png)

---

## VR

---

### ロコモーション

XRRigを動かす機能群

![XRRig](./ImageForDocument/XRRig.png)

---

#### SnapTurnProvider

コントローラの水平キー入力でカメラを回転させる機能

<video height="500"><source src="ImageForDocument/SnapTurn.mp4"></video>

---

![SnapTurnProvider](./ImageForDocument/SnapTurnProvider.png)

---

#### TeleportationProvider

後述のTeleportationAnchor, Areaを駆動する

<video height="500"><source src="ImageForDocument/TeleportationProvider.mp4"></video>

---

![TeleportationProvider](./ImageForDocument/TeleportationProvider.png)

---

#### TeleportationAnchor

指定したアンカーの中心にテレポートする機能

<video height="500"><source src="ImageForDocument/TeleportationAnchor.mp4"></video>

---

![TeleportationAnchor](./ImageForDocument/TeleportationAnchor.png)

---

#### TeleportationArea

指定したエリアのどこへでもテレポートできる機能

<video height="500"><source src="ImageForDocument/TeleportationArea.mp4"></video>

---

![TeleportationArea](./ImageForDocument/TeleportationArea.png)

---

## AR

### Interactor

動作の主体

---

#### ARGestureInteractor

タップ、スワイプ、ピンチなどで、オブジェクトを操作する機能  
**はまりポイント**: AR CameraにMainCameraタグが必要

<!-- 
GetValidTargets()内でCamera.mainを使用する -> 
MainCameraタグが必要 -> 
しかしAR CameraにはデフォルトでMainCameraタグがついていない
-->

![ARGestureInteractor](./ImageForDocument/ARGestureInteractor.png)

---

AR上の画像

---

### Interactable

動作の客体

---

#### ARPlacementInteractable

平面に設定されているプレハブを生成する

![ARPlacementInteractable](./ImageForDocument/ARPlacementInteractable.png)

---

AR上の画像

---

#### ARRotationInteractable

// todo:

---

AR上の画像

---

#### ARScaleInteractable

// todo:

---

AR上の画像

---

#### ARSelectionInteractable

// todo:

---

AR上の画像

---

#### ARTranslationInteractable

// todo:

---

AR上の画像

---

#### ARAnnotationInteractable

// todo:

---

AR上の画像

---

## まとめ

<span style="font-size: 35px" >

UnityはXR系の開発環境を一本化しようとしているぞ  
AR,MR周りはAR Foundationを使うといいぞ  
(要コントローラー)人間からの入力を共通化できるぞ  
なんかXR Interaction Toolkitの機能の説明をしたぞ  

コントローラーぁ...

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
