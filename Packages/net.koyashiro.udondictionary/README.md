# UdonDictionary

Dictionary implementation for UdonSharp.

## Installation

To use this package, you need to add [my package repository](https://github.com/koyashiro/vpm-repos).
Please read more details [here](https://github.com/koyashiro/vpm-repos#installation).

Please install this package with [Creator Companion](https://vcc.docs.vrchat.com/) or [VPM CLI](https://vcc.docs.vrchat.com/vpm/cli/).

### Creator Companion

1. Enable the `koyashiro` package repository.

   ![image](https://user-images.githubusercontent.com/6698252/230629434-048cde39-a0ec-4c53-bfe2-46bde2e6a57a.png)

2. Find `UdonDictionary` from the list of packages and install any version you want.

### VPM CLI

1. Execute the following command to install the package.

   ```sh
   vpm add package net.koyashiro.udondictionary
   ```

## Example

```cs
using UdonSharp;
using UnityEngine;
using Koyashiro.UdonDictionary;

public class UdonDictionarySample : UdonSharpBehaviour
{
    public void Start()
    {
        var dic = UdonDictionary<string, int>.New(); // {}

        dic.SetValue("first", 1);  // { first: 1 }
        dic.SetValue("second", 2); // { first: 1, second: 2 }
        dic.SetValue("third", 3);  // { first: 1, second: 2, third: 3 }

        Debug.Log(dic.GetValue("first"));  // 1
        Debug.Log(dic.GetValue("second")); // 2
        Debug.Log(dic.GetValue("third"));  // 3
    }
}
```
