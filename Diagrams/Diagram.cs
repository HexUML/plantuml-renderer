namespace HexUML.PlantUmlRenderer.Diagrams
{
    public abstract class Diagram
    {
        public string Title { get; }
        public string Description { get; }

        protected Diagram(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public abstract override string ToString();
    }
}