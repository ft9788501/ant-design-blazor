---
category: Components
type: 数据录入
title: Slider
subtitle: 滑动输入条
---

滑动型输入器，展示当前值和可选范围。

## 何时使用

- 当用户需要在数值区间/自定义区间内进行选择时，可为连续或离散值。



## API

| 参数             | 说明                                         | 类型          | 默认值    |
| ---------------- | -------------------------------------------- | ------------- | --------- |
| defaultValue            | 	设置初始取值。当 range 为 false 时，使用 number，否则用 [number, number]        | number         |
| disabled            | 值为 true 时，滑块为禁用状态         | boolean         |-       |
| dots |	是否只能拖拽到刻度上     | boolean        | -         |
| included |  marks 不为空对象时有效，值为 true 时表示值为包含关系，false 表示并列                             | boolean        | -         |
| marks | 刻度标记，key 的类型必须为 number 且取值在闭区间 [min, max] 内，每个标签可以单独设置样式       | object         |
| max | 最大值                          | number        | -         |
| min | 最小值                     | number       | -         |
| range | 双滑块模式                          | boolean        | -         |
| reverse | 反向坐标轴                          | boolean       | -         |
| step | 步长，取值必须大于 0，并且可被 (max - min) 整除。当 marks 不为空对象时，可以设置 step 为 null，此时 Slider 的可选值仅有 marks 标出来的部分。                            | number        | -         |
| value | 设置当前取值。当 range 为 false 时，使用 number，否则用 [number, number]                          | number        | -         |
| vertical | 	值为 true 时，Slider 为垂直方向                           | boolean        | -         |
| onAfterChange | 与 onmouseup 触发时机一致，把当前值作为参数传入。                          | function(e)        | -         |
| onChange | 	当 Slider 的值发生改变时，会触发 onChange 事件，并把改变后的值作为参数传入。                           | function(e)        | -         |
| tooltipPlacement | 设置 Tooltip 展示位置。参考 Tooltip。                           | string        | -         |
| tooltipVisible | 值为true时，Tooltip 将会始终显示；否则始终不显示，哪怕在拖拽及移入时。                           | boolean        | -         |
| getTooltipPopupContainer |Tooltip 渲染父节点，默认渲染到 body 上。                           | Rendfragment        | -         |



