
Polygon poly1 = new Polygon("Fred", new edge("a", 5), new edge("b",4), new edge("c",3));

Console.WriteLine(poly1);

Console.WriteLine("Which edge would you like to change?");
string edge = Console.ReadLine();
Console.Write("What Sixe do you want to change it to?");
string entry = Console.ReadLine();
double length = double.Parse(entry);

poly1.ChangeEdge(edge, length);
Console.WriteLine(poly1);


class edge
{
    public string Name;
    public double Length;
    public edge(string name, double length)
    {
        Name = name;
        Length = length;
    }   
}
class Polygon
{
    public string Name;
    public  List<edge> edges;
    public Polygon(string _Name, edge edge1, edge edge2, edge edge3)
    {
        Name= _Name;
        edges = new List<edge>();
        edges.Add(edge1);
        edges.Add(edge2);
        edges.Add(edge3);

    }

    public void AddEdge(edge another)
    {
        edges.Add(another);
    }
    public void ChangeEdge(string which, double newLength)
    {
        //foreach(edge ed in edges)
        //{
        //    if(ed.Name == which)
        //    {
        //        ed.Length = newLength;
        //        return;
        //    }
        //}
        edge found = null;
        foreach(edge ed in edges)
        {
            if(ed.Name == which)
            {
                found = ed;
                break;
            }
        }if(found != null)
        {
            found.Length = newLength;
        }
    }
    public override string ToString()
    {
        string result = "";
        string comma = "";
        foreach (edge ed in edges)
        {
            result = result + $"{comma}{ed.Name}:{ed.Length}";
            comma = ",";
        }
        return $"{Name} = {result}";
    }
}