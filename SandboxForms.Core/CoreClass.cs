using System;

namespace SandboxForms.Core
{
    using Newtonsoft.Json;

    public static class CoreClass
    {
        public static JsonSerializer Serializer { get; set; } = new JsonSerializer();
    }
}
