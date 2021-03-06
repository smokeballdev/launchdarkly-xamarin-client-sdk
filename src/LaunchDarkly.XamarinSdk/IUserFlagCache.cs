﻿using System.Collections.Immutable;
using LaunchDarkly.Client;

namespace LaunchDarkly.Xamarin
{
    internal interface IUserFlagCache
    {
        void CacheFlagsForUser(IImmutableDictionary<string, FeatureFlag> flags, User user);
        IImmutableDictionary<string, FeatureFlag> RetrieveFlags(User user);
    }

    internal sealed class NullUserFlagCache : IUserFlagCache
    {
        public void CacheFlagsForUser(IImmutableDictionary<string, FeatureFlag> flags, User user) { }
        public IImmutableDictionary<string, FeatureFlag> RetrieveFlags(User user) => ImmutableDictionary.Create<string, FeatureFlag>();
    }
}
