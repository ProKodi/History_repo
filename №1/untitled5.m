k = 1.25;
T1 = 0.18^2; T2 = 2*0.95*0.18; T3 = 1; T4 = 0;
num1 = [k];
den1 = [T1 T2 T3 T4];
W = tf(num1, den1);
subplot(121); step(W,5);
subplot(122); impulse(W,5);