



b2=40;

%временные характеристики
W0=tf(a1,[1 b1 b2]); %устойчивое инерционное звено
subplot(121); step(W0,3); %переходной процесс
subplot(122); impulse(W0,3); %весовая функция

%частотные характеристики
num=a1; den=[1 b1 b2];
[re,im]=nyquist(num,den);
subplot(221); plot(re); %вещественная
subplot(222); plot(im); %мнимая
subplot(223); nyquist(num,den); %годограф
subplot(224); bode(num,den); %логарифмические


b2 = start_b2;