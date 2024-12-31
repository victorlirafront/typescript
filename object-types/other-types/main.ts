// any
// object
// unknown
// never

function handleTypes(input: any): void {
  // `any` permite receber qualquer tipo de entrada
  console.log('Input (any):', input);

  // `object`: aceita apenas objetos ou arrays
  let obj: object;
  if (typeof input === 'object' && input !== null) {
    obj = input;
    console.log('Object:', obj);
  } else {
    console.log('Not an object');
  }

  // `unknown`: exige verificação antes do uso
  let unknownValue: unknown = input;
  if (typeof unknownValue === 'string') {
    console.log('Unknown as string:', unknownValue.toUpperCase());
  } else if (typeof unknownValue === 'number') {
    console.log('Unknown as number:', unknownValue + 10);
  }

  // `never`: utilizado para lidar com casos impossíveis
  function handleError(message: string): never {
    throw new Error(message);
  }

  if (typeof input === 'undefined') {
    handleError('Input cannot be undefined!');
  }
}

// Exemplos de chamada
handleTypes({ name: 'Victor' });
handleTypes(42);
handleTypes('Hello');
// handleTypes(undefined); // Lança um erro!
