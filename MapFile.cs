using System.Text;

namespace KB.WorldMap;

public class MapFile
{
    private readonly string _path;

    private char[,] _testMap =
    {
        { 'H', 'w' },
        { 'g', 'T' },
    };

    public MapFile(string path)
    {
        _path = path;
    }

    public async Task SaveLoad()
    {
        string path = $"@{_path}";

        string text = string.Empty;
        var rows = _testMap.GetUpperBound(0) + 1;
        var columns = _testMap.Length / rows;

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                text += _testMap[x, y];
            }
        }

        using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
            await fstream.WriteAsync(buffer, 0, buffer.Length);
        }

        using (FileStream fstream = File.OpenRead(path))
        {
            byte[] buffer = new byte[fstream.Length];
            await fstream.ReadAsync(buffer, 0, buffer.Length);
            string textFromFile = Encoding.Default.GetString(buffer);

            Console.Clear();
            Console.WriteLine($"Text from the file: {textFromFile}");
            Console.ReadKey();
        }
    }
}