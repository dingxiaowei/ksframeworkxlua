﻿#region Copyright (c) 2015 KEngine / Kelly <http://github.com/mr-kelly>, All rights reserved.

// KEngine - Toolset and framework for Unity3D
// ===================================
// 
// Filename: SettingModuleEditor.cs
// Date:     2015/12/03
// Author:  Kelly
// Email: 23110388@qq.com
// Github: https://github.com/mr-kelly/KEngine
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3.0 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library.

#endregion

using UnityEngine;
using System.Collections;
using KEngine.Editor;
using UnityEditor;

/// <summary>
/// 可以对KSFramework的部分静态编辑器类，进行自定义代码设置
/// </summary>
[InitializeOnLoad]
public class KSFrameworkCustom
{
    static KSFrameworkCustom()
    {
        // 定义配置表条件编译变量
        //SettingModuleEditor.CompileSettingConditionVars = new[] {"I18N_ZH_CN"};
    }
}
