using System;

namespace Microsoft.Xna.Framework.Content
{
    public interface IContentManager
    {
        string RootDirectory { get; set; }
        IServiceProvider ServiceProvider { get; }

        void Dispose();
        T Load<T>(string assetName);
        T LoadLocalized<T>(string assetName);
        void Unload();
    }
}