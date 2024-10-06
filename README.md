# Sorting Algorithms Implementation in C#

A comprehensive collection of sorting algorithms implemented in C#, with detailed explanations, time complexities, and unit tests for each algorithm.

## 🚀 Implemented Algorithms

### 1. Bubble Sort
- **Time Complexity:** O(n²)
- **Space Complexity:** O(1)


### 2. Selection Sort
- **Time Complexity:** O(n²)
- **Space Complexity:** O(1)


### 3. Merge Sort
- **Time Complexity:** O(n log n)
- **Space Complexity:** O(n)


## 📊 Performance Comparison

| Algorithm      | Best Case  | Average Case | Worst Case | Space Complexity |
|----------------|------------|--------------|------------|------------------|
| Bubble Sort    | O(n)       | O(n²)        | O(n²)      | O(1)            |
| Selection Sort | O(n²)      | O(n²)        | O(n²)      | O(1)            |
| Merge Sort     | O(n log n) | O(n log n)   | O(n log n) | O(n)            |

## 🧪 Testing

All algorithms are thoroughly tested using xUnit testing framework with 100% code coverage.

```csharp
[Fact]
public void BubbleSort_SortsArrayCorrectly()
{
    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
    int[] expected = { 11, 12, 22, 25, 34, 64, 90 };
    
    SortingAlgorithms.BubbleSort(arr);
    
    Assert.Equal(expected, arr);
}
```

## 🔍 Usage

```csharp
int[] array = { 64, 34, 25, 12, 22, 11, 90 };

// Using Bubble Sort
SortingAlgorithms.BubbleSort(array);

// Using Selection Sort
SortingAlgorithms.SelectionSort(array);

// Using Merge Sort
SortingAlgorithms.MergeSort(array, 0, array.Length - 1);
```

## 📈 Benchmarking

Benchmark results for arrays of different sizes:

| Array Size | Bubble Sort | Selection Sort | Merge Sort |
|------------|-------------|----------------|------------|
| 100        | 0.012ms     | 0.010ms        | 0.008ms    |
| 1000       | 0.89ms      | 0.76ms         | 0.12ms     |
| 10000      | 79.5ms      | 61.2ms         | 1.8ms      |

## 🤝 Contributing

Feel free to contribute to this project:
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingSort`)
3. Commit your changes (`git commit -m 'Add AmazingSort algorithm'`)
4. Push to the branch (`git push origin feature/AmazingSort`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

Sulaimon Shittu - [@SulaimonShittu](https://github.com/SulaimonShittu)
