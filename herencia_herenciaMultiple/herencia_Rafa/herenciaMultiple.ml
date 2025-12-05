class swimmer = object
  method swim = print_endline "swimming"
end;; 

class cyclist = object 
  method pedal = print_endline "pedaleando"
end;;

class runner = object 
  method run = print_endline "running"
end;;

class triathlete = object 
  inherit swimmer
  inherit cyclist
  inherit runner
  method compete = print_endline "in a challenge"
end;;

let t = new triathlete;;

t#swim;
t#pedal;
t#run;
t#compete