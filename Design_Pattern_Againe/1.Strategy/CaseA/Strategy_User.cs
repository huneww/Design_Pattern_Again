using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 플레이어 클래스
public class Strategy_User
{
    // 현재 플레잉어가 장착하고있는 무기
    Strategy_TakeWeapon takeWeapon;

    // 플레이어 생성시 장착 무기 설정
    public Strategy_User(Strategy_IWeapon weapon)
    {
        // takeWeapon 초기화
        takeWeapon = new Strategy_TakeWeapon(weapon);
    }

    // 장착 무기 변경
    public void SetWeapon(Strategy_IWeapon weapon)
    {
        // takeWeapon의 무기 변경 메서드 호출
        takeWeapon.SetWeapon(weapon);
    }

    // 장착 무기 액션 실행
    public void UseWeapon()
    {
        // takeWeapon의 무기 사용 메서드 호출
        takeWeapon.UseWeapon();
    }

}
