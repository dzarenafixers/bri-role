using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BRI_Role
{
    public class Config : IConfig
    {
        [Description("هل البلغن مفعل؟")]
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; }

        [Description("أقصى عدد يمكن أن يكونوا BRI في الجولة.")]
        public int MaxBRI { get; set; } = 2;
    }
}