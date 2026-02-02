%временные характеристики 
W0=tf([1.7],[1 4.5 0]); %устойчивое инерционное звено 
subplot(121); step(W0,5); %переходной процесс 
subplot(122); impulse(W0,5); %весовая функция

%частотные характеристики 
num=[1.7]; den=[1 4.5 0]; 
[re,im]=nyquist(num,den); 
subplot(221); plot(re); %вещественная
subplot(222); plot(im); %мнимая
subplot(223); nyquist(num,den); %годограф
subplot(224); bode(num,den); %логарифмические
