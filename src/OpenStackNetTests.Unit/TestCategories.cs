﻿namespace OpenStackNetTests.Live
{
    internal static class TestCategories
    {
        public const string Cleanup = "Cleanup (Simulated)";

        public const string User = "User (Simulated)";

        public const string Identity = "Identity (Simulated)";

        /// <summary>
        /// This test category should be applied to tests which should run in the automated build environment as part of
        /// validating a pull request or other change.
        /// </summary>
        public const string Unit = "Unit";
    }
}
