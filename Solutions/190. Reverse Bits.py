class Solution:
    def reverseBits(self, n: int) -> int:
        binary = f'{n:032b}'
        reverse_binary = binary[::-1]    
        return int(reverse_binary,2)
