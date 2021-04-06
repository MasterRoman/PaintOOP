using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.Json;
using System.Text.Json.Serialization;


namespace PaintOOP.Model.SerializeModel
{
    public interface ISerialization<TFigure> where TFigure : IFigure
    {
        string serialize();
        TFigure deserialize(string json);

    }


    class Wrapper          //wrapper for retrieving type after deserialization
    {
        public string type { get; set; }
        public string data { get; set; }

        public Wrapper()
        {
        }
        public Wrapper(string type, string data)
        {
            this.type = type;
            this.data = data;
        }
    }

    public class ColorJsonConverter : JsonConverter<System.Drawing.Color>   //custom serialization of color
    {
        public override System.Drawing.Color Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            string str = reader.GetString();
            Int32 argb = Convert.ToInt32(str);
            return System.Drawing.Color.FromArgb(argb);
        }

        public override void Write(
            Utf8JsonWriter writer,
            System.Drawing.Color color,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(color.ToArgb().ToString()
                    );
    }
}
