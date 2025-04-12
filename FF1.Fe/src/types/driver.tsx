export default interface Driver {

  id: string;
  status: string;
  description: string;
  isPrimary: boolean;
  broadcasterName: string;
  firstName: string;
  lastName: string;
  country: string;
  nameAcronim: string;
  headshotUrl: string;
  driverNumber: number;
  teamId: string;
  birthday: Date;
  pitCoin: number;
  points: number;
}
