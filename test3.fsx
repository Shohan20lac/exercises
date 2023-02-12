let digitCount number = 
    (int) (log10 ((float)number)) + 1;

printfn $"{digitCount 100}" 