using Lib.Enum;

namespace Lib.Models
{
    public struct Result
    {
        public MessageType Message { get; set; }
        public Input Input { get; set; }
        public double Root1 { get; set; }
        public double Root2 { get; set; }
    }
}
