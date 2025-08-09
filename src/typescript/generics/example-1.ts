function identity<T>(value: T): T {
    return value;
  }
  
  const num = identity<number>(5);      // num é number
  const str = identity<string>("hello");// str é string
  