# 遠端介面更新紀錄

## Version 1 (110/11/11)

- 上傳穩定版本

## Version 2 (110/11/19)

- 修正多筆資料傳送
  - 原本：手臂由右序列傳送        (loading -> rotate_arm -> 1st_arm -> 2nd_arm -> 3rd_arm -> hand)
  - 修正：手臂由反方向序列傳送 (hand-> 3rd_arm -> 2nd_arm -> 1st_arm -> rotate_arm -> loading)
  - 原因：原本資列傳送序列會導致旋轉軸為最後一個移動，將會導致手臂卡住，因此需要由夾爪開始移動。

## Version 3 (110/11/20)

 - 修正多筆資料拉桿同步移動