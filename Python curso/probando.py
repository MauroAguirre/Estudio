class MaxSum:

    @staticmethod
    def find_max_sum(numbers):
        ordenados = numbers.sort()
        return ordenados[len(numbers)]+ordenados[len(numbers)-1]

print(MaxSum.find_max_sum([5, 9, 7, 11]))