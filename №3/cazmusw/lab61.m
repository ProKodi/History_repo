margin = 1;

kp = b2 / a1;
W0 = tf(kp*a1, [1 b1 kp*a1-b2]);

subplot(231); step(W0, 3); 
subplot(234); impulse(W0, 3); 

kp = b2 / a1 + margin;
W1 = tf(kp*a1, [1 b1 kp*a1-b2]);

subplot(232); step(W1, 3); 
subplot(235); impulse(W1, 3); 

kp = b2 / a1 - margin;
W2 = tf(kp*a1, [1 b1 kp*a1-b2]);

subplot(233); step(W2, 3); 
subplot(236); impulse(W2, 3); 


