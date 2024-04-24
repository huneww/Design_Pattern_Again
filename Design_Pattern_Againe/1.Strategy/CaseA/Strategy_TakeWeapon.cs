using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 장착 무기 관리 클래스
public class Strategy_TakeWeapon
{
    // 현재 장착 중인 무기
    Strategy_IWeapon curWeapon;

    // 생성자에서 장착 무기 초기화
    public Strategy_TakeWeapon(Strategy_IWeapon curWeapon)
    {
        // 현재 무기 설정
        this.curWeapon = curWeapon;
    }

    // 장착 무기 변경
    public void SetWeapon(Strategy_IWeapon setWeapon)
    {
        // 현재 무기 변경
        this.curWeapon = setWeapon;
    }

    // 무기 액션
    public void UseWeapon()
    {
        // 장착 무기가 없다면 오류 반환
        if (curWeapon == null)
        {
            Console.WriteLine("Empty Weapon");
            return;
        }
        // 현재 무기의 액션과 정보 출력
        curWeapon.WeaponAction().WeaponInfo();
    }

}
