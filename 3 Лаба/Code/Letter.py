



from collections import Counter


class Letter:
    """ Класс буквы """


    def __init__(self, let:str, prb:float, code:str):
        """
        Args:
            prb (float): Верояность буквы
            code (str): Код буквы
        """
        self.let = let
        # Буква 
        self.prb = prb
        # Верояность буквы
        self.code = code
        # Код буквы


    def __len__(self) -> int:
        """ Число знаков в кодовом слове """
        return len(self.code)
    
    def __repr__(self) -> str:
        return f"{self.let}[ prb:{round(self.prb, 2)}, code:{self.code}]"
    
    def __eq__(self, other):
        """ Оператор == """
        if(type(other) != Letter): return False
        if(self.let != other.let):  return False
        if(self.prb != other.prb):  return False
        if(self.code != other.code):  return False
        return True

    
    def ParseText(string: str) -> list["Letter"]:
        string = string.lower()
        freq = Counter(string)
    
        total_len = len(string)
        probs = {c: freq[c] / total_len for c in freq}
    
        symbols = sorted(probs.items(), key=lambda x: x[1], reverse=True)
    
        codes = {}
    
        def shannon_fano(symbols, prefix=""):
            # если один символ — присваиваем код
            if len(symbols) == 1:
                symbol = symbols[0][0]
                codes[symbol] = prefix or "0"  # важно для случая одного символа
                return
    
            # ищем оптимальное разделение (минимальная разница сумм)
            total = sum(p for _, p in symbols)
    
            best_split = 1
            left_sum = 0
            min_diff = float("inf")
    
            for i in range(1, len(symbols)):
                left_sum += symbols[i - 1][1]
                right_sum = total - left_sum
                diff = abs(left_sum - right_sum)
    
                if diff < min_diff:
                    min_diff = diff
                    best_split = i
    
            left = symbols[:best_split]
            right = symbols[best_split:]
    
            # защита от пустых частей (редкий, но возможный кейс)
            if left:
                shannon_fano(left, prefix + "0")
            if right:
                shannon_fano(right, prefix + "1")
    
        shannon_fano(symbols)
    
        return [
            Letter(s, p, codes[s]) for s, p in symbols
        ]