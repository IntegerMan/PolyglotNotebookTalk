def largest_fibonacci(n):
    """
    Calculates the largest Fibonacci number up to a given number.
    
    Args:
        n (int): The maximum number to calculate the largest Fibonacci number before.
        
    Returns:
        int: The largest Fibonacci number before the given number.
    """

    a, b = 0, 1
    while b < n:
        a, b = b, a + b
    return a