// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Build.Evaluation;

namespace NuGet.CommandLine.XPlat
{
    internal interface IProjectCollectionAdapter
    {
        void UnloadProject(Project project);
    }
}