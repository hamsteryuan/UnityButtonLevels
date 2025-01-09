# UnityButtonLevels
这是一个开源的unity的多层按钮交互界面的可使用模版。一层按钮可以触发不同的二层按钮，后续相应。一共提供了四层按钮的模版。相应事件接口例子提供。This is an available template for the open source unity multi-layer button interface. Layer 1 buttons can trigger different layer 2 buttons. A total of four layers of button templates are provided. Corresponding event interface examples are provided.
每个文件里都有注释。
是自己兴趣开发，希望能帮到一些人！
## 具体功能
每个按钮能够识别:<br>
1.是否出现。如果自己所在相应层级根本没有通过点击更高层级激活，或者自己层级激活但只激活了3个按钮而这个按钮是第4个，那么不出现。<br>
2.是否处于鼠标浮在上方的状态，如果是，改变颜色（可以调整）<br>
3.是否处于被选中状态，如果是，改变颜色（可以调整）；被选中下，再次点击会取消选中，点击同层和更高层也会取消选中（激活）<br>
4.点击后触发事件。分为两部分：一部分是非界面交互事件，一部分是触发下一面界面。
## 代码介绍
1.xxxLevelButton 是绑定在每一层按钮的prefab上<br>
2.xxxListener 和 xxx TextUpdator 可以分别建一个空gameobject绑定。然后把对应层object与按钮相应拖入。二者分别表示控制按钮点击事件和控制按钮文本显示<br>
3.把交互界面（这里以4层为例）分别建4个gameobject，每个gameobject里面建多个按钮（为这一层所要的最大按钮数量）。在建立一个gameobject，里面放非交互的界面东西，比如一个不可修改，只会因为某个按钮点击而显示的文本框，这个gameobject就相当于是一个虚拟的第五层。<br>
4.Atomosphere是表示氛围灯，可有可无，这里可以当作一个举例按钮操作效果的东西<br>
5.LevelManager很重要。因为逻辑上点击按钮后，先去判定当前属于什么子界面下，再去触发功能。<br>
6.接口和注释可以看文件里。有一些函数已经填入了范例。
