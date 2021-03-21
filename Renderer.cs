using System.Threading.Tasks;
using HexUML.PlantUmlRenderer.Diagrams;
using PlantUml.Net;

namespace HexUML.PlantUmlRenderer
{
    public class Renderer
    {
        private IPlantUmlRenderer PlantUmlRenderer { get; }

        public Renderer(PlantUmlSettings plantUmlSettings = null)
        {
            PlantUmlRenderer = new RendererFactory().CreateRenderer(plantUmlSettings ?? new PlantUmlSettings { RemoteUrl = "https://www.plantuml.com/plantuml/" });
        }
        public async Task<byte[]> Render(string diagramSource, OutputFormat outputFormat = OutputFormat.Svg)
        {
            //TODO: Add Options to the renderer.
            //TODO: Add Filters to the renderer.
            //TODO: Add Styles to the renderer.
            return await PlantUmlRenderer
                .RenderAsync(diagramSource, outputFormat)
                .ConfigureAwait(false);
        }

        public async Task<byte[]> Render(Diagram diagram, OutputFormat outputFormat = OutputFormat.Svg)
        {
            return await Render(diagram.ToString(), outputFormat).ConfigureAwait(false); ;
        }
    }
}