k = 1.25;
T1 = power(0.18,2); T2 = 2*0.95*0.18; T3 = 1; T4 = 0;
num1 = [k];
den1 = [T1 T2 T3 T4];
[re, im]=nyquist(num1, den1);
subplot(221); plot(re);
subplot(222); plot(im);
subplot(223); nyquist(num1, den1);
subplot(224); bode(num1, den1);