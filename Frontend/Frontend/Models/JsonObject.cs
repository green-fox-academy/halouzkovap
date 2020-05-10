namespace Frontend.Models
{
    public class JsonObject
    {
        public int Until { get; set; }
        public bool HasValue { get; internal set; }

        public JsonObject()
        {

        }
        public JsonObject(int inpu)
        {
            this.Until = inpu;
        }
    }
}
