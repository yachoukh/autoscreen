﻿namespace AutoScreenCapture
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class VersionCollection : IEnumerable<Version>
    {
        private readonly List<Version> _versionList = new List<Version>();

        public List<Version>.Enumerator GetEnumerator()
        {
            return _versionList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Version>)_versionList).GetEnumerator();
        }

        IEnumerator<Version> IEnumerable<Version>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Version version)
        {
            _versionList.Add(version);
        }

        public Version Get(string appCodename, string appVersion)
        {
            foreach (Version version in _versionList)
            {
                if (version.Codename.Equals(appCodename) &&
                    version.VersionString.Equals(appVersion))
                {
                    return version;
                }
            }

            return null;
        }
    }
}
