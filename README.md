# UnityButtonLevels
这是一个开源的unity的多层按钮交互界面的可使用模版。一层按钮可以触发不同的二层按钮，后续相应。一共提供了四层按钮的模版。相应事件接口例子提供。This is an available template for the open source unity multi-layer button interface. Layer 1 buttons can trigger different layer 2 buttons. A total of four layers of button templates are provided. Corresponding event interface examples are provided.
每个文件里都有注释。
是自己兴趣开发，希望能帮到一些人！
## 具体功能
每个按钮能够识别:
1.是否出现。如果自己所在相应层级根本没有通过点击更高层级激活，或者自己层级激活但只激活了3个按钮而这个按钮是第4个，那么不出现。
2.是否处于鼠标浮在上方的状态，如果是，改变颜色（可以调整）
3.是否处于被选中状态，如果是，改变颜色（可以调整）；被选中下，再次点击会取消选中，点击同层和更高层也会取消选中（激活）
