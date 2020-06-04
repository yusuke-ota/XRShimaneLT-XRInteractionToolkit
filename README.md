# XRShimaneLT-XRInteractionToolkit

地域おこしXR研究会第5回勉強会の発表用

基本1機能1シーン構成になっています。特定の機能のみ集中して見てみたいときなどにご利用ください。  
また、XRInteractionToolkitを使ってみた話.mdに各機能のはまりやすいコンポーネントの設定等を載せています。適宜参照してください。

XRInteractionToolkitでどんなことができるか1シーンで知りたいときは、Unityの公開している[サンプル](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples)の方が適しています。

## 使用ツール

* vscode-reveal  
マークダウンをスライドに変換するのに使用  
静止画版スライド  
<https://speakerdeck.com/yusukeota/yusuke-xrshimane5-presentation>

* Unity  
デモの作成に使用

## 動作確認済みデバイス

### VR

- HTC Vive
- Oculus Quest

### AR

- AR Core(AR Foundation)

## 動作状況

|シーン名|状況|備考|
|:---:|:---:|:---:|
|Direct Interactor|〇||
|Ray Interactor|〇||
|Socket Interactor|〇||
|Grab Interactable|〇||
|Tint InteractableVisual|〇||
|UI Interaction|△|ドロップダウンの中身を選択できません|
|SnapTurnProvider|〇||
|TeleportationProvider|〇||
|TeleportationAnchor|〇||
|TeleportationArea|〇||
|ARGesture Interactor|〇||
|ARPlacementInteractable|〇||
|ARRotationInteractable|〇||
|ARScaleInteractable|〇||
|ARSelectionInteractable|〇||
|ARTranslationInteractable|〇||
|ARAnnotationInteractable|×|動作しません|
