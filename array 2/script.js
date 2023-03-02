const numbers= [5, 18, 98, 45, 0, 67];
let max = 0;
let min = 0;
for(let i = 0; i < numbers.length; i++)
   {
     if( numbers[i] != max && numbers[i] < min)
         {
             min = numbers[i];
          }
       if(numbers[i] > max)
           {
               max = numbers[i];
           }
    }
        console.log(max);
        console.log(min);
