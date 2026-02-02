num=[1.9]; den=[1 0.5];
[re,im]=nyquist(num,den);
subplot(221); plot(re); %вещественная
subplot(222); plot(im); %мнимая
subplot(223); nyquist(num,den); %годограф
subplot(224); bode(num,den); %логарифмические