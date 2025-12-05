class person (name: string) = object
  val mutable _name = name 
    
  method get_name = name  
  
end;;

class student (name: string) = object
  inherit person name
  method study = print_endline (_name ^ " está estudiando")
end;;

class teacher (name: string) = object
  inherit person name
  method teach = print_endline (_name ^ " está enseñando")
end;;

let emilio = new student "Emilio";;
emilio#study;;

let mag = new teacher "Mag";;
mag#teach;;