import sys

def quickSort(numbers, left, right):
    
    if len(numbers) == 1:
        return numbers
    if left < right:
        pivot = partition(numbers, left, right)
        quickSort(numbers, left, pivot - 1)
        quickSort(numbers, pivot + 1, right)


def partition(numbers, left, right):
    pivot = numbers[right]
    i = left
    for j in range(left, right+1):

        if numbers[j] <= pivot:
            numbers[i], numbers[j] = numbers[j], numbers[i]
            i = i+1
    return i - 1

if __name__ == '__main__':
    for line in sys.stdin:
        input = line.split()[1:]
        numbers = [int(elem) for elem in line.split()][1:]
    n = len(numbers)
    quickSort(numbers, 0, n-1)

    for i in range(n):
        print("%d" % numbers[i])