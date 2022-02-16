// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace NuGet.PackageManagement.VisualStudio
{
    public interface IPackageReferenceProject
    {
        /// <summary>
        /// Gets the both the installed (top level) and transitive package references for this project.
        /// Returns the package reference as two separate lists (installed and transitive).
        /// </summary>
        /// <param name="token">Cancellation token</param>
        /// <returns>A <see cref="ProjectPackages"/> object with two lists: Installed and transitive packages</returns>
        public Task<ProjectPackages> GetInstalledAndTransitivePackagesAsync(CancellationToken token);
    }
}