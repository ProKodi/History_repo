



W0 = tf([b1 b2], [1 0]); % ПИ-регулятор
W1 = tf([0.1*a1*b1+a1 b1], [0.1*a1 1]); % ПД-регулятор
W2 = tf([a1+0.1*a1*b1 b1+b2*0.1*a1 b2], [0.1*a1 1 0]); % ПИД-регулятор

subplot(321); step(W0, 10);title('ПИ-регулятора');
subplot(323); step(W1, 10);title('ПД-регулятора');
subplot(325); step(W2, 30);title('ПИД-регулятора');

subplot(322); impulse(W0, 10);title('ПИ-регулятора');
subplot(324); impulse(W1, 10);title('ПД-регулятора');
subplot(326); impulse(W2, 10);title('ПИД-регулятора');

