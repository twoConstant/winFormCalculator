using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public class MemoryFunction
    {
        
        // 메모리 리스트 생성
        public List<double> MemoryStorage { get; set; }
        // 리스트 박스 생성
        public ListBox MemoryListBox { get; set; } // 외부에서 접근 가능한 속성으로 변경
        
        // 생성자에서 초기화
        public MemoryFunction()
        {
            MemoryStorage = new List<double>();
            // MemoryListBox = new ListBox
            // {
            //     Size = new System.Drawing.Size(120, 100), // 크기 설정
            //     Location = new System.Drawing.Point(10, 70), // 초기 위치 설정
            //     Visible = false, // 초기에는 숨김
            //     ScrollAlwaysVisible = true // 항상 스크롤바 표시
            // };
            
        }
        
        // 메모리 초기화
        public void ClearMemory()
        {
            MemoryStorage.Clear();
        }
        
        // 메모리의 마지막 요소 출력
        public double RecallMemory()
        {
            if (MemoryStorage.Any())
            {
                return MemoryStorage.Last();        
            }
            return 0;
            
        }

        // 현재 화면에 나타난 값을 메모리의 마지막 요소에 저장 
        public void PlusMemory(double value)
        {
            if (MemoryStorage.Any())
            {
                MemoryStorage[MemoryStorage.Count - 1] += value;    
            }
            else
            {
                MemoryStorage.Add(value);    
            }
            
        }
        
        // 현재 화면에 나타난 값을 메모리의 마지막 요소에 저장
        public void MinusMemory(double value)
        {
            if (MemoryStorage.Any())
            {
                MemoryStorage[MemoryStorage.Count - 1] -= value;
            }
            else
            {
                MemoryStorage.Add(-value);    
            }
                    
        }
        
        // 메모리 리스트에 새로운 요소로 저장
        public void StoreMemory(double value)
        {
            MemoryStorage.Add(value);
        }
        
        // // 리스트박스 외부 클릭 감지 및 리스트 박스 숨기기
        // public void CloseMemoryListBox(MouseEventArgs e)
        // {
        //     switch (MemoryListBox.Visible)
        //     {
        //         case true when !MemoryListBox.Bounds.Contains(e.Location):
        //             MemoryListBox.Visible = false; // 리스트박스를 숨김
        //             break;
        //     }
        // }
        // // Mv button 눌렀을 때 화면에 리스트 박스 보이기
        // public void ClickMemoryList(object sender, EventArgs e)
        // {
        //     switch (MemoryListBox.Visible)
        //     {
        //         case false:
        //             UpdateMemoryList();
        //             MemoryListBox.Visible = true;
        //             break;
        //     }
        // }
        //
        // public void UpdateMemoryList()
        // {
        //     MemoryListBox.Items.Clear(); // 리스트박스 초기화
        //     foreach (double value in MemoryStorage.AsEnumerable().Reverse()) // 최근 값부터 출력
        //     {
        //         MemoryListBox.Items.Add(value);
        //     }
        // }

    }
}