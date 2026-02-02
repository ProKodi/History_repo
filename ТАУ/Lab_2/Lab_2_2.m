w0 = tf([1.9],[1 0.5*0.25]);
subplot(421); step(w0,1);  
subplot(422); impulse(w0,1); 

w1 = tf([1.9],[1 0.5*0.5]);
subplot(423); step(w1,1);  
subplot(424); impulse(w1,1); 

w2 = tf([1.9],[1 0.5*2]);
subplot(425); step(w2,1);  
subplot(426); impulse(w2,1); 

w3 = tf([1.9],[1 0.5*4]);
subplot(427); step(w3,1);  
subplot(428); impulse(w3,1); 