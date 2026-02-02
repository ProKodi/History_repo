b2=100;

%частотные характеристики
num=a1; den=[1 b1 b2];
[re,im]=nyquist(num,den);
subplot(221); plot(re); %вещественная
subplot(222); plot(im); %мнимая
subplot(223); nyquist(num,den); %годограф
subplot(224); bode(num,den); %логарифмические

b2 = start_b2;