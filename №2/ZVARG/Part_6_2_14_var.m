%частотные характеристики  
num=[1 4.2]; den=[8.6 2];  
[re,im]=nyquist(num,den);  
subplot(221); plot(re); %вещественная  
subplot(222); plot(im); %мнимая  
subplot(223); nyquist(num,den); %годограф  
subplot(224); bode(num,den); %логарифмические