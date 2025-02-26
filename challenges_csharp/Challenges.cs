namespace challenges_csharp;

public class Challenges {
    public int[] ArrayOfMultiples(int num, int multiple)
    {
        // Enumerable.Range -> generates a sequence of integers within a specified range.
        return Enumerable.Range(1, multiple).Select(i => num * i).ToArray(); // Python: range(start, end) 
    }

    public string ReverseCase(string txt)
    {
        // .Select -> is a LINQ method that projects (transforms) each element of a collection into a new form.
        // c => ... -> it's a lambda function.
        // .Select() -> the result is an IEnumerable<char>.
        // .ToArray() -> converts this sequence into a char[].
        return new string(txt.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
    }
}