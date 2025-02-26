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

    public string ReverseAndNot(string i)
    {
        if (Convert.ToInt32(i) >= 0)
        {
            return new string(i.Reverse().ToArray()) + i;
        }
        
        return "";
    }

    // Create a function that determines whether the input sentence is a smooth sentence
    public bool IsSmooth(string s)
    {
        // phrase for the challenge: "Marta appreciated deep perpendicular right trapezoids"
        // "Marta appreciated deep perpendicular right trapezoids" (True)
        // "Marta appreciate deep perpendicular right trapezoids" (False)
        
        // .Zip() --> is used to combine two sequences (or collections) into a sequence of tuples by pairing
        // corresponding elements from both sequences. The resulting sequence will have the same number of elements as
        // the smaller of the two sequences.
        
        // .Skip() --> Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        // arr.Skip(2) -> normal: [1, 2, 3, 4, 5, 6, 7] --> [3, 4, 5, 6, 7]
        
        // .All() --> method in LINQ is used to check if all elements in a sequence satisfy a given condition.
        // It returns true if every element in the sequence meets the condition, and false if any element does not.
        
        string[] arr = s.Split();
        return arr.Zip(arr.Skip(1), (preview, current) => preview[preview.Length - 1] == current[0])
            .All(res => res); // The predicate .All(...)
    }
}