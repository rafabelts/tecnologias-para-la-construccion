class worker (name: string) (income: float) = object
  val mutable name = name
  val mutable income = income
  method get_name = name
  method get_income = income
end;;

class chief (name: string) (income: float) = object
  inherit worker name income
  method manage_team = print_endline "dirigiendo al equipo"
end;;

class programmer (name: string) (income: float) = object
  inherit worker name income
  method code = print_endline "programando"
end;;

class accountant (name: string) (income: float) = object
  inherit worker name income
  method manage_accounts = print_endline "contando"
end;;

let jessica = new chief "Jessica" 100.5;;
let fernando = new programmer "Fernando" 60.5;;
let jair = new accountant "Jair" 20.5;;

print_endline jessica#get_name;;
jessica#manage_team;;
jessica#get_income;;

print_endline fernando#get_name;;
fernando#code;;
fernando#get_income;;

print_endline jair#get_name;;
jair#manage_accounts;;
jair#get_income;;
