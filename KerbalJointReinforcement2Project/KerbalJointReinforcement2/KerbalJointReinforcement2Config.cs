using SpaceWarp.API.Configuration;
using Newtonsoft.Json;

namespace KerbalJointReinforcement2
{
    [JsonObject(MemberSerialization.OptOut)]
    [ModConfig]
    public class KerbalJointReinforcement2Config
    {
         [ConfigField("pi")] [ConfigDefaultValue(3.14159)] public double pi;
    }
}