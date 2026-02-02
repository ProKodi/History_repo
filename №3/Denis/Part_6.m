






margin = 1;

kp = b2 / a1;
W0 = tf(kp*a1, [1 b1 kp*a1-b2]);

kp = b2 / a1 + margin;
W1 = tf(kp*a1, [1 b1 kp*a1-b2]);

kp = b2 / a1 - margin;
W2 = tf(kp*a1, [1 b1 kp*a1-b2]);


subplot(121); step(W0,W1,W2,5); %переходной процесс
subplot(122); impulse(W0,W1,W2,5); %весовая функция
