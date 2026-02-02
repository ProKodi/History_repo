W0 = tf([b1 b2], [1 0]); % ПИ-регулятор
W1 = tf([0.1*a1*b1+a1 b1], [0.1*a1 1]); % ПД-регулятор
W2 = tf([a1+0.1*a1*b1 b1+b2*0.1*a1 b2], [0.1*a1 1 0]); % ПИД-регулятор

subplot(231); step(W0, 3); 
subplot(232); step(W1, 3); 
subplot(233); step(W2, 3); 

subplot(234); impulse(W0,3); 
subplot(235); impulse(W1,3); 
subplot(236); impulse(W2,3); 

